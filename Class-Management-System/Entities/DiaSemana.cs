using Class_Management_System.Enums;
using Class_Management_System.Interfaces;
using System.Collections.Generic;
using System;
using System.Web.Script.Serialization;

namespace Class_Management_System.Entities
{
    public class DiaSemana : IDado
    {
        private List<Aula> materias;
        private Horario horario;
        private DiaLetivo descricaoDia;
        private int materias_cadastradas { get { return this.materias.Count; } } //Variável interna e para debug
        public DiaSemana(Horario horario, DiaLetivo dia)
        {
            this.horario = horario;
            this.descricaoDia = dia;
            this.materias = new List<Aula>(8);
        }

        public DiaSemana(Horario horario, DiaLetivo dia, List<Aula> materias)
        {
            this.horario = horario;
            this.descricaoDia = dia;
            this.materias = new List<Aula>(8);
            this.AdicionarMaterias(materias);
        }

        /// <summary>
        /// Insere uma nova máteria para um dia e um horário da semana
        /// Se não houver estourado o limite de matérias para esse dia e horário
        /// </summary>
        /// <param name="materia"></param>
        public void AdicionarMateria(Aula materia)
        {
            if (this.materias.Count < this.materias.Capacity && !this.materias.Contains(materia))
            {
                this.materias.Add(materia);
            }
        }

        /// <summary>
        /// Insere uma lista de novas máterias para um dia e um horário da semana
        /// Se não houver estourado o limite de matérias para esse dia e horário
        /// </summary>
        /// <param name="materia"></param>
        public void AdicionarMaterias(List<Aula> materias)
        {
            this.materias.AddRange(materias.FindAll(materia =>
            this.materias.Count < this.materias.Capacity && !this.materias.Contains(materia)));
        }

        /// <summary>
        /// Remove uma matéria se ela estiver na lista de matérias
        /// </summary>
        /// <param name="materia"></param>
        public void RemoverMateria(Aula materia)
        {
            if (this.materias.Contains(materia))
            {
                this.materias.Remove(materia);
            }
        }

        /// <summary>
        /// Verifica se já existe uma máteria para o mesmo período,
        /// horario e dia.
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        public bool ExisteAulaNoPeriodo(Aula aula)
        {
            Aula retorno = this.materias.Find(aula_ => aula_.GetDisciplina().GetPeriodo() == aula.GetDisciplina().GetPeriodo());
            return retorno != null;
        }

        public bool Equals(IDado other)
        {
            if (other is DiaSemana)
            {
                DiaSemana dia = (DiaSemana)other;
                if (this.horario != dia.horario) return false;
                else if (this.descricaoDia != dia.descricaoDia) return false;
                return true;
            }
            return false;
        }

        public int CompareTo(IDado other)
        {
            if (other is DiaSemana)
            {
                DiaSemana aux = (DiaSemana)other;
                if (this.descricaoDia < aux.descricaoDia) return -1;
                else if (this.descricaoDia > aux.descricaoDia) return 1;
                return 0;
            }
            throw new ArgumentException("Objeto do parâmetro não é do tipo DiaSemana");
        }

        /// <summary>
        /// Cria um json do DiaSemana
        /// </summary>
        /// <returns></returns>
        public object GetValor()
        {
            return new JavaScriptSerializer().Serialize(this).ToString();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Horario GetHorario()
        {
            return this.horario;
        }

        public DiaLetivo GetDia()
        {
            return this.descricaoDia;
        }
    }
}