using Class_Management_System.Models.Enums;

namespace Class_Management_System.Models.Entities.Interns
{
    public class Materia
    {
        private Periodo periodo;
        private Professor professor;
        private Disciplina disciplina;
        private int aulasSemana;
        public Materia(Periodo periodo, Professor professor, Disciplina disciplina, int aulasSemana)
        {
            this.periodo = periodo;
            this.professor = professor;
            this.disciplina = disciplina;
            this.aulasSemana = aulasSemana;
        }

        public Periodo GetPeriodo()
        {
            return this.periodo;
        }
        
        public Professor GetProfessor()
        {
            return this.professor;
        }

        public Disciplina GetDisciplina()
        {
            return this.disciplina;
        }

        public int GetAulasPorSemana()
        {
            return this.aulasSemana;
        }

        public void DiminuirAulasPorSemanas()
        {
            if(this.aulasSemana > 1)
            {
                this.aulasSemana--;
            }
        }
    }
}