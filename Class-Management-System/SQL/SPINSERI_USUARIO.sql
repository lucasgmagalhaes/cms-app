DROP PROCEDURE SPINSERI_USUARIO;
DELIMITER $$ 
CREATE PROCEDURE SPINSERI_USUARIO(
   IN sLogin  VARCHAR(20) ,
   IN sSenha  VARCHAR(20) ,
   IN pkPerfil VARCHAR(20) ,
   IN pkPessoa  INTEGER)
 BEGIN
    INSERT  INTO USUARIO
            ( LOGIN ,
              SENHA ,
              COD_PERFIL_USUARIO ,
              COD_PESSOA
            )
    VALUES  ( sLogin ,
              sSenha ,
              pkPerfil ,
              pkPessoa
            );
END $$
DELIMITER ;