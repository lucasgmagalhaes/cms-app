using Class_Management_System.Entities;
using System.Collections.Generic;

namespace Class_Management_System.Services
{
    interface IAulaService
    {
        /// <summary>
        /// Recebe o arquivo arquivo e cria uma lista de objetos do tipo Aula referente as linhas
        /// lidas.
        /// </summary>
        /// <param name="arquivo"></param>
        /// <returns></returns>
        List<Aula> CriarListaDeAulas(List<string> arquivo);
        
        /// <summary>
        /// Busca uma aula pelo nome do professor. Retorna null caso não seja encontrado nada
        /// </summary>
        /// <param name="aulas"></param>
        /// <param name="nomeProfessor"></param>
        /// <returns></returns>
        Aula BuscarAulaPorNomeProfessor(List<Aula> aulas, string nomeProfessor);
        
        /// <summary>
        /// Busca uma aula pelo nome da matéria. Retorna null caso nao seja encontrado nada
        /// </summary>
        /// <param name="aulas"></param>
        /// <param name="nomeMateria"></param>
        /// <returns></returns>
        Aula BuscarAulaPorNomeDisciplina(List<Aula> aulas, string nomeMateria);
    }
}
