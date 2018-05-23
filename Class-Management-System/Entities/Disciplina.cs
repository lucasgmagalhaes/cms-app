using Class_Management_System.Enums;

namespace Class_Management_System.Entities
{
    public class Disciplina
    {
        private string nome;
        private Periodo periodo;
        private Professor professor;
        public Disciplina(string nome, Periodo periodo, Professor professor)
        {
            this.nome = nome;
            this.periodo = periodo;
            this.professor = professor;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public Periodo GetPeriodo()
        {
            return this.periodo;
        }

        public Professor GetProfessor()
        {
            return this.professor;
        }
    }
}