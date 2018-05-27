CREATE PROCEDURE SPINSERI_USUARIO
    @sLoginUS AS NVARCHAR(20) ,
    @sSenhaUS AS NVARCHAR(20) ,
    @pkPerfilUS AS INTEGER ,
    @pkPessoaUS AS INTEGER
AS
    INSERT  INTO dbo.USUARIO
            ( LOGIN ,
              SENHA ,
              COD_PERFIL_USUARIO ,
              COD_PESSOA
            )
    VALUES  ( @sLoginUS ,
              @sSenhaUS ,
              @pkPerfilUS ,
              @pkPessoaUS
            );