using Class_Management_System.Enums;
using Class_Management_System.Interfaces;
using System.Collections.Generic;
using System;
using System.Web.Script.Serialization;

namespace Class_Management_System.Entities
{
    public class DiaSemana : IDado
    {
        private List<Aula> aulas;
        private Horario horario;
        private DiaLetivo descricaoDia;
        private int aulas_cadastradas { get { return this.aulas.Count; } } //Variável interna e para debug
        public DiaSemana(Horario horario, DiaLetivo dia)
        {
            this.horario = horario;
            this.descricaoDia = dia;
            this.aulas = new List<Aula>(8);
        }

        public DiaSemana(Horario horario, DiaLetivo dia, List<Aula> aulas)
        {
            this.horario = horario;
            this.descricaoDia = dia;
            this.aulas = new List<Aula>(8);
            this.AdicionarAulas(aulas);
        }

        /// <summary>
        /// Insere uma nova aula para um dia e um horário da semana
        /// Se não houver estourado o limite de matérias para esse dia e horário
        /// </summary>
        /// <param name="materia"></param>
        public void AdicionarAula(Aula materia)
        {
            if (this.aulas.Count < this.aulas.Capacity && !this.aulas.Contains(materia))
            {
                this.aulas.Add(materia);
            }
        }

        /// <summary>
        /// Insere uma lista de novas aulas para um dia e um horário da semana
        /// Se não houver estourado o limite de matérias para esse dia e horário
        /// </summary>
        /// <param name="materia"></param>
        public void AdicionarAulas(List<Aula> aulas)
        {
            this.aulas.AddRange(aulas.FindAll(materia =>
            this.aulas.Count < this.aulas.Capacity && !this.aulas.Contains(materia)));
        }

        /// <summary>
        /// Remove uma matéria se ela estiver na lista de matérias
        /// </summary>
        /// <param name="materia"></param>
        public void RemoverMateria(Aula materia)
        {
            if (this.aulas.Contains(materia))
            {
                this.aulas.Remove(materia);
            }
        }

        /// <summary>
        /// Verifica se já existe uma aula para o mesmo período,
        /// horario e dia.
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        public bool ExisteAulaNoPeriodo(Aula aula)
        {
            return this.aulas.Find(aula_ => aula_.GetDisciplina().GetPeriodo() 
            == aula.GetDisciplina().GetPeriodo()) != null;
        }

        /// <summary>
        /// Verifica se existe alguma aula com o professor passado por parâmetro
        /// </summary>
        /// <param name="professor">Professor</param>
        /// <returns></returns>
        public bool ExisteAulaComProfessor(Professor professor)
        {
            return this.aulas.Find(aula_ => aula_.GetProfessor().Equals(professor)) != null;
        }

        /// <summary>
        /// É retornado TRUE se o dado informado for do tipo DiaSemana e se ele possuir o mesmo
        /// horário e DiaLetivo que o diaSemana que está comparando
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna -1 se o diaSemana do parâmatro for de um dia depois do dia do objeto atual,
        /// 1 se for menor, e 0 se forem iguais.
        /// Lança a exceção ArgumentException se o objeto do parâmetro não for do tipo DiaSemana
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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

        public List<Aula> GetAulas()
        {
            return this.aulas;
        }
    }
}