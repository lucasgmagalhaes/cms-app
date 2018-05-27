CREATE PROC [dbo].[SPCRIA_ACESSO]
    @sNome AS NVARCHAR(MAX) ,
    @sCpf AS NVARCHAR(MAX) ,
    @sEmail AS NVARCHAR(MAX) = '' ,
    @sLoginUS AS NVARCHAR(20) ,
    @sSenhaUS AS NVARCHAR(20) ,
    @pkPerfilUS AS INTEGER
AS
    DECLARE @PKPESSOA AS INTEGER = ( SELECT COD_PESSOA
                                     FROM   PESSOA
                                     WHERE  COD_CPF = @sCpf
                                   );
    IF @PKPESSOA = 0
        BEGIN
            EXEC SPCRIA_PESSOA @sNomePessoa = @sNome, @sCpfPessoa = @sCpf,
                @sEmailPessoa = @sEmail;
        END
    SET @PKPESSOA = ( SELECT    COD_PESSOA
                      FROM      PESSOA
                      WHERE     COD_CPF = @sCpf
                    );
    EXEC SPINSERI_USUARIO @sLogin = @sLoginUS, @sSenha = @sSenhaUS,
        @pkPerfil = @pkPerfilUS, @pkPessoa = @PKPESSOA;