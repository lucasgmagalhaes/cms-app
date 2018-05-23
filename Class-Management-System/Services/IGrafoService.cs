using Class_Management_System.Entities;
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
        Grafo GerarHorarios(List<Vertice> vertices);
        
        /// <summary>
        /// Gera um dia da semana(segunda, terça, quarta, quinta e sexta)
        /// para cada horário(primerio e segundo). Ou seja, há um dia da semana que é segunda - primeiro horário
        /// e segunda - segundo horário, por exemplo.
        /// </summary>
        /// <returns></returns>
        List<DiaSemana> GerarDiasDaSemana();
    }
}
