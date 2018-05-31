DELIMITER $$
CREATE  PROCEDURE  SPCRIA_PESSOA(
   IN sNomePessoa VARCHAR(255),
   IN	sCpfPessoa VARCHAR(255),
   IN sEmailPessoa VARCHAR(255) 
    )
BEGIN
		SET sEmailPessoa = IFNULL(sEmailPessoa, '');
			INSERT INTO PESSOA
					(COD_CPF ,
					 NOME_PESSOA,
					 EMAIL)
				VALUES(sNomePessoa ,sCpfPessoa ,sEmailPessoa);
 #SET @PKPESSOA = (SELECT COD_PESSOA FROM PESSOA WHERE COD_CPF = sCpfPessoa);
 END $$
DELIMITER ;
