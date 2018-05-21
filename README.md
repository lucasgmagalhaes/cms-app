# Sistema de gestão de horário. 4º período TI

## Tema
Especificação e implementação de um sistema de informação.

## Objetivo geral
Fazer a especificação de um Sistema de Gestão de horários de disciplinas e implementar
algumas funcionalidades.
Alocação de horários
Considere que você seja o responsável para montar o horário do curso de Sistemas de
Informação – São Gabriel (noite) da PUC Minas. O problema consiste em alocar os
professores às suas disciplinas de forma a maximizar o número de disciplinas em
paralelo. Considere que alguns professores possam ministrar diversas disciplinas, e que
por dia, possamos ter 2 horários de alocação.

# Estrutura do arquivo a ser lido
### v1 
> nome_da_disciplina;nome_do_professor;período
### v2
> nome_da_disciplina;nome_do_professor;período;qtd_aulas_semana 

# Exemplo tabela gerada

| Período       | Matéria       | Professor | Horário | Dia Semana | 
|:-------------:|:-------------:|:---------:|:-------:|:----------:|
| 1º            | ATP           |  Hugo     |   2º    | Segunda    | 
| 2º            | POO           |  Caram    |   1º    | Terça      | 
| 3º            | AED           |  Caram    |   1º    | Segunda    |

# Estrutura do grafo que é gerado
![alt text](https://github.com/lgmagalhaes88/cms-app/blob/master/docs/GrafoDiagrama.png)

# Estrutura de classes do grafo
![alt text](https://github.com/lgmagalhaes88/cms-app/blob/master/docs/Estrutura_Classes_Grafo.png)

# Resultado final Grafo
![alt text](https://github.com/lgmagalhaes88/cms-app/blob/master/docs/Desenho_Grafo.png)

# Modelo lógico do banco de dados: 
![alt text](https://github.com/lgmagalhaes88/cms-app/blob/master/docs/BD/Outros%20Arquivos/TI_BD_LOGICO.png)

[Link para visualizar a descrição do projeto](https://github.com/lgmagalhaes88/cms-app/blob/master/docs/TI%20Grafos%201_2018_ER_BD.pdf)
