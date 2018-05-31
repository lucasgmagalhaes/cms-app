DELIMITER $$
CREATE PROCEDURE  SPCRIA_ACESSO (
    sNome  VARCHAR(255) ,
    sCpf  VARCHAR(255) ,
    sEmail  VARCHAR(255)  ,
    sLoginUS  VARCHAR(20) ,
    sSenhaUS  VARCHAR(20) ,
    pkPerfilUS INTEGER)
BEGIN
	SET sEmail = IFNULL(sEmail, '');
    SET @PKPESSOA = ( SELECT COD_PESSOA
                                     FROM   PESSOA
                                     WHERE  COD_CPF = @sCpf
                                   );
    IF (@PKPESSOA = 0) THEN 
            CALL SPCRIA_PESSOA (sNomePessoa = sNome, sCpfPessoa = sCpf,
                sEmailPessoa = sEmail);
        END IF;
    SET @PKPESSOA = ( SELECT    COD_PESSOA
                      FROM      PESSOA
                      WHERE     COD_CPF = sCpf
                    );
    CALL SPINSERI_USUARIO (sLogin = sLoginUS, sSenha = sSenhaUS,
        pkPerfil = pkPerfilUS, pkPessoa = @PKPESSOA);
END $$
DELIMITER ;