DELIMITER $$ 
CREATE PROCEDURE SPINSERI_USUARIO(
   IN sLoginUS  VARCHAR(20) ,
   IN sSenhaUS  VARCHAR(20) ,
   IN pkPerfilUS  VARCHAR(20) ,
   IN pkPessoaUS  INTEGER)
 BEGIN
    INSERT  INTO USUARIO
            ( LOGIN ,
              SENHA ,
              COD_PERFIL_USUARIO ,
              COD_PESSOA
            )
    VALUES  ( sLoginUS ,
              sSenhaUS ,
              pkPerfilUS ,
              pkPessoaUS
            );
END $$
DELIMITER ;