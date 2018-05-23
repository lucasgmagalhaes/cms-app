using System;
using Class_Management_System.Interfaces;
using System.Web.Script.Serialization;

namespace Class_Management_System.Entities
{
    public class Aula : IDado
    {
        private Professor professor;
        private Disciplina disciplina;
        private int aulasSemana;
        private int aulasSemanaRestante;
        public Aula(Professor professor, Disciplina disciplina, int aulasSemana)
        {
            this.professor = professor;
            this.disciplina = disciplina;
            this.aulasSemana = aulasSemana;
            this.aulasSemanaRestante = this.aulasSemana;
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

        /// <summary>
        /// Retorna quantas aulas na semana essa matéria ainda pode ter.
        /// </summary>
        /// <returns></returns>
        public int GetAulasPorSemanaRestante()
        {
            return this.aulasSemanaRestante;
        }

        /// <summary>
        /// Diminui em 1 o valor do número de aulas por semana restantes se o valor for maior que 0
        /// </summary>
        public void DiminuirAulasPorSemanasRestante()
        {
            if (this.aulasSemanaRestante > 0)
            {
                this.aulasSemanaRestante--;
            }
        }

        /// <summary>
        /// Faz a comparação usando todos as propriedades da classe
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(IDado other)
        {
            if (other is Aula)
            {
                Aula aux = (Aula)other;
                if (!this.professor.GetNome().Equals(aux.GetProfessor().GetNome())) return false;
                else if (!this.disciplina.GetNome().Equals(aux.GetDisciplina().GetNome())) return false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Faz a comparação pelo período entre duas matérias. 
        /// Se esta matéria for de um periodo superior ao da matéria do parâmetro, é retornado 1,
        /// se for menor, -1. Se forem do mesmo período, 0. Se o objeto não for do tipo 'Materia', 
        /// é gerada uma exceção do tipo 'ArgumentException'
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(IDado other)
        {
            if (other is Aula)
            {
                Aula aux = (Aula)other;
                if (this.disciplina.GetPeriodo() < aux.disciplina.GetPeriodo()) return -1;
                else if (this.disciplina.GetPeriodo() > aux.disciplina.GetPeriodo()) return 1;
                return 0;
            }
            throw new ArgumentException("Objeto do parâmetro não é do tipo Matéria");
        }

        /// <summary>
        /// Cria um json da Materia
        /// </summary>
        /// <returns></returns>
        public object GetValor()
        {
            return new JavaScriptSerializer().Serialize(this);
        }

        /// <summary>
        /// Faz um clone superficial da Matéria
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return (Aula)this.MemberwiseClone();
        }
    }
}