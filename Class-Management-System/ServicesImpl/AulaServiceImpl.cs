using Class_Management_System.Entities;
using Class_Management_System.Enums;
using Class_Management_System.Services;
using System.Collections.Generic;

namespace Class_Management_System.ServicesImpl
{
    public class AulaServiceImpl : IAulaService
    {
        public List<Aula> CriarListaDeAulas(List<string> arquivo)
        {
            List<Aula> aulas = new List<Aula>();
            string[] partes;
            Professor professor;
            Disciplina disciplina;
            Aula aula_;
            Periodo periodo;

            arquivo.ForEach(linha =>
            {
                partes = linha.Split(';');

                aula_ = this.BuscarAulaPorNomeProfessor(aulas, partes[1]);
                if (aula_ == null) professor = new Professor(partes[1]);
                else professor = aula_.GetProfessor();

                periodo = PeriodoUtil.BuscarPorValor(int.Parse(partes[2]));

                aula_ = this.BuscarAulaPorNomeDisciplina(aulas, partes[0]);
                if (aula_ == null) disciplina = new Disciplina(partes[0], periodo, professor);
                else disciplina = aula_.GetDisciplina();

                aulas.Add(new Aula(professor, disciplina, int.Parse(partes[3])));
            });
            return aulas;
        }

        public Aula BuscarAulaPorNomeProfessor(List<Aula> aulas, string nomeProfessor)
        {
            if (aulas == null) return null;
            return aulas.Find(aula => aula.GetProfessor().GetNome().Equals(nomeProfessor));
        }

        public Aula BuscarAulaPorNomeDisciplina(List<Aula> aulas, string nomeMateria)
        {
            if (aulas == null) return null;
            return aulas.Find(aula => aula.GetDisciplina().GetNome().Equals(nomeMateria));
        }
    }
}
