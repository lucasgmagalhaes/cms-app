DROP PROCEDURE SPCRIA_ACESSO;
DELIMITER $$
CREATE PROCEDURE  SPCRIA_ACESSO (
    sNome  VARCHAR(100) ,
    sCpf  VARCHAR(11) ,
    sEmail  VARCHAR(100)  ,
    sLoginUS  VARCHAR(20) ,
    sSenhaUS  VARCHAR(20) ,
    pkPerfilUS INTEGER)
BEGIN
	SET sEmail = IFNULL(sEmail, '');
    SET @PKPESSOA = ( SELECT COD_PESSOA
                                     FROM   PESSOA
                                     WHERE  COD_CPF = sCpf
                                   );
	SET @PKPESSOA = IFNULL(@PKPESSOA, 0);                            
    IF (@PKPESSOA = 0) THEN 
         CALL SPCRIA_PESSOA (  sNome,   sCpf,  sEmail);
        END IF;
    SET @PKPESSOA = ( SELECT    COD_PESSOA
                      FROM      PESSOA
                      WHERE     COD_CPF = sCpf
                    );
    CALL SPINSERI_USUARIO ( sLoginUS,  sSenhaUS,
        pkPerfilUS,  @PKPESSOA);
END $$
DELIMITER ;