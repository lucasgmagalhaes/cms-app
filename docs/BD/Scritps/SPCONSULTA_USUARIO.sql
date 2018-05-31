DELIMITER $$
CREATE PROCEDURE  SPCONSULTA_USUARIO (  IN sLogin VARCHAR(20) ,   IN pkUsuario VARCHAR(4) ,    IN sNomePessoa VARCHAR(100) ,  IN sCpf VARCHAR(100)   )
BEGIN
	 SET pkUsuario = IFNULL(pkUsuario, '0');
	 SET sLogin = IFNULL(sLogin, '');
	 SET sNomePessoa = IFNULL(sNomePessoa, '');
	 SET sCpf = IFNULL(sCpf, '');  
	 SET @sSql = 'SELECT  U.COD_USUARIO ID ,
            U.LOGIN LOGIN ,
            PU.DSC_PERFIL_USUARIO PERFIL ,
            P.NOME_PESSOA,
 	        P.COD_CPF,
	        P.EMAIL,
			P.COD_PESSOA,
			PU.COD_PERFIL_USUARIO,
			U.SENHA
    FROM    USUARIO U
            LEFT JOIN PERFIL_USUARIO PU ON PU.COD_PERFIL_USUARIO = U.COD_PERFIL_USUARIO
            LEFT JOIN PESSOA P ON P.COD_PESSOA = U.COD_PESSOA WHERE 1=1 ';
    IF (pkUsuario <> '0')  THEN 
            SET @sSql = @sSql + ' AND U.COD_USUARIO = ' + pkUsuario; 	
         END IF;
    IF (sLogin <> '' ) THEN 
            SET @sSql = @sSql + ' AND U.NOME_USUARIO LIKE ''' + sLogin + '%''';
         END IF;
    IF (sNomePessoa <> '')  THEN 
            SET @sSql = @sSql + ' AND P.NOME_PESSOA LIKE ''' + sNomePessoa + '%''';
         END IF;
    IF (sCpf <> '') THEN 
            SET @sSql  = @sSql + ' AND P.COD_CPF = ''' + sCpf + '''';
            END IF;
	PREPARE myquery FROM @sSql;
    EXECUTE myquery; 
	DEALLOCATE PREPARE myquery;
END $$
DELIMITER ;