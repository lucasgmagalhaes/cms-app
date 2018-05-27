CREATE PROC [dbo].[SPGRAVA_DADOS_USUARIO]
    @sNome AS NVARCHAR(MAX) ,
    @sCpf AS NVARCHAR(MAX) ,
    @sEmail AS NVARCHAR(MAX) = '' ,
    @sLoginUS AS NVARCHAR(20) ,
    @sSenhaUS AS NVARCHAR(20) ,
    @pkPerfilUS AS INTEGER ,
    @pkUsuario AS INTEGER
AS
    DECLARE @PKPESSOA AS INTEGER = 0; 
    SET @PKPESSOA = ( SELECT    COD_PESSOA
                      FROM      USUARIO U
                      WHERE     U.COD_USUARIO = @pkUsuario
                    );
    UPDATE  U
    SET     U.COD_PERFIL_USUARIO = @pkPerfilUS ,
            U.SENHA = @sSenhaUS ,
            U.LOGIN = @sLoginUS
    FROM    USUARIO U
    WHERE   U.COD_USUARIO = @pkUsuario;

    UPDATE  P
    SET     P.EMAIL = @sEmail ,
            P.NOME_PESSOA = @sNome ,
            P.COD_CPF = @sCpf ,
            P.EMAIL = @sEmail
    FROM    PESSOA P
    WHERE   P.COD_PESSOA = @PKPESSOA;