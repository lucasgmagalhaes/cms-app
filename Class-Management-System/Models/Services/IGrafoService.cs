using Class_Management_System.Models.Entities.Interns;
using Class_Management_System.Models.Structures;
using System.Collections.Generic;

namespace Class_Management_System.Models.Services
{
    interface IGrafoService
    {
        /// <summary>
        /// Recebe um arquivo com as inforamações do professor, matéria e período.
        /// Lê essas informações e gera um grafo com a tabela de horários gerada
        /// </summary>
        /// <param name="arquivo"></param>
        /// <returns></returns>
        Grafo GerarHorarios(string[] arquivo);
        
        /// <summary>
        /// Gera um dia da semana(segunda, terça, quarta, quinta e sexta)
        /// para cada horário(primerio e segundo). Ou seja, há um dia da semana que é segunda - primeiro horário
        /// e segunda - segundo horário, por exemplo.
        /// </summary>
        /// <returns></returns>
        List<DiaSemana> GerarDiasDaSemana();
    }
}
