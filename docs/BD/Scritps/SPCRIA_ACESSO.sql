CREATE  PROC [dbo].[SPCRIA_ACESSO]
    @sNome AS NVARCHAR(MAX),
	@sCpf AS NVARCHAR(MAX),
	@sEmail AS NVARCHAR(MAX) = '',
	@sLogin AS NVARCHAR(20) ,
	@sSenha AS NVARCHAR(20) ,
	@pkPerfil AS INTEGER
AS  
DECLARE @PKPESSOA AS INTEGER = (SELECT COD_PESSOA FROM PESSOA WHERE COD_CPF = @sCpf) 
IF @PKPESSOA > 0
BEGIN	
EXEC SPCRIA_PESSOA @sNomePessoa = @sNome,@sCpfPessoa = @sCpf, @sEmailPessoa = @sEmail
 --INSERT INTO PESSOA
 --(COD_CPF ,
 --NOME_PESSOA,
 --EMAIL)
 --VALUES(@sNome ,@sCpf ,@sEmail)
 END  
 EXEC SPINSERI_USUARIO   @sLogin = @sLoginUS   ,
	@sSenha  = @sSenhaUS ,
	@pkPerfil = @pkPerfilUS,
    @pkPessoa  =@pkPessoaUS 
 
