using Class_Management_System.Entities;
using Class_Management_System.Enums;
using Class_Management_System.Structures;
using System.Collections.Generic;

namespace Class_Management_System.Services
{
    /// <summary>
    /// Servico para criação do grafo das aulas
    /// </summary>
    interface IGrafoService
    {
        /// <summary>
        /// Recebe um arquivo com as inforamações do professor, matéria e período.
        /// Lê essas informações e gera um grafo com a tabela de horários gerada
        /// </summary>
        /// <param name="arquivo"></param>
        /// <returns></returns>
        Grafo GerarHorarios(List<Vertice> vertices, out List<Aula> aulasVazias);

        /// <summary>
        /// Gera um dia da semana(segunda, terça, quarta, quinta e sexta)
        /// para cada horário(primerio e segundo). Ou seja, há um dia da semana que é segunda - primeiro horário
        /// e segunda - segundo horário, por exemplo.
        /// </summary>
        /// <returns></returns>
        List<DiaSemana> GerarDiasDaSemana();

        /// <summary>
        /// Busca todos os vértices do tipo 'Aula'
        /// </summary>
        /// <param name="grafo"></param>
        /// <returns></returns>
        List<Vertice> BuscarVerticesAula(Grafo grafo);

        /// <summary>
        /// Retorna o dia semana disponível para a matéria passada por parâmetro.
        /// Para "dia disponível" é verificado quais dias da semana não tem aula para o período
        /// em que a matéria é, e se já não existe uma matéria com o mesmo professor da aula passada por parâmetro.
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        DiaSemana GetDiaDisponivelParaMateria(Aula aula, List<DiaSemana> dias);

        /// <summary>
        /// Informa o total de aulas na semana todas as aulas juntas terão
        /// </summary>
        /// <param name="aulas"></param>
        /// <returns></returns>
        int GetTotalDiasRestantesAulas(List<Aula> aulas);

        /// <summary>
        /// Retorna os horários gerados no formato formato de linhas, sendo que, cada linha estará no 
        /// seguinte formato: Período;Matéria;Professor;Horário;Dia Semana
        /// </summary>
        /// <param name="vertices"></param>
        /// <returns></returns>
        List<string> GerarHorariosFormatados(List<Vertice> vertices, out List<Aula> aulasVazias);

        /// <summary>
        /// Busca todos os vértices do tipo 'DiaSemana'
        /// </summary>
        /// <param name="grafo"></param>
        /// <returns></returns>
        List<Vertice> BuscarVerticesDiaSemana(Grafo grafo);

        /// <summary>
        /// Busca uma lista de dias da semana pela descricao do dia
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="dias"></param>
        /// <returns></returns>
        List<DiaSemana> GetDiaSemanaPorDescricaoDia(DiaLetivo dia, List<DiaSemana> dias);
    }
}
