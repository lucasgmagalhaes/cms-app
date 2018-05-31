DELIMITER $$
CREATE PROCEDURE  SPGRAVA_DADOS_USUARIO(
   IN sNome   VARCHAR(255) ,
   IN sCpf   VARCHAR(11) ,
   IN sEmail   VARCHAR(255)   ,
   IN sLoginUS   VARCHAR(20) ,
   IN sSenhaUS   VARCHAR(20) ,
   IN pkPerfilUS   INTEGER ,
   IN pkUsuario   INTEGER
    )
BEGIN
 SET sEmail = IFNULL(sEmail, '');
    SET @PKPESSOA  = 0; 
    SET @PKPESSOA = ( SELECT    COD_PESSOA
                      FROM      USUARIO U
                      WHERE     U.COD_USUARIO = pkUsuario
                    );
                     
UPDATE USUARIO U 
SET 
    U.COD_PERFIL_USUARIO = pkPerfilUS,
    U.SENHA = sSenhaUS,
    U.LOGIN = sLoginUS
WHERE
    U.COD_USUARIO = pkUsuario;
UPDATE PESSOA P 
SET 
    P.EMAIL = sEmail,
    P.NOME_PESSOA = sNome,
    P.COD_CPF = sCpf,
    P.EMAIL = sEmail
WHERE
    P.COD_PESSOA = @PKPESSOA; 
END $$
DELIMITER ;