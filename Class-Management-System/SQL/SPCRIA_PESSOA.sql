DROP PROCEDURE SPCRIA_PESSOA;
DELIMITER $$
CREATE  PROCEDURE  SPCRIA_PESSOA(
   IN sNomePessoa VARCHAR(100),
   IN	sCpfPessoa VARCHAR(11),
   IN sEmailPessoa VARCHAR(100)  
    )
BEGIN
		SET sEmailPessoa = IFNULL(sEmailPessoa, '');
			INSERT INTO PESSOA
					( NOME_PESSOA ,
					 COD_CPF,
					 EMAIL)
				VALUES(sNomePessoa ,sCpfPessoa ,sEmailPessoa); 
 END $$
DELIMITER ;
