using Class_Management_System.Models.Enums;
using System.Collections.Generic;

namespace Class_Management_System.Models.Entities.Interns
{
    public class DiaSemana
    {
        private List<Materia> materias;
        private Horario horario;
        private DiaLetivo descricaoDia;
        private int materias_cadastradas { get { return this.materias.Count; } } //Variável interna e para debug
        public DiaSemana(Horario horario, DiaLetivo dia)
        {
            this.horario = horario;
            this.descricaoDia = dia;
            this.materias = new List<Materia>(8);
        }

        public DiaSemana(Horario horario, DiaLetivo dia, List<Materia> materias)
        {
            this.horario = horario;
            this.descricaoDia = dia;
            this.materias = new List<Materia>(8);
            this.AdicionarMaterias(materias);
        }

        /// <summary>
        /// Insere uma nova máteria para um dia e um horário da semana
        /// Se não houver estourado o limite de matérias para esse dia e horário
        /// </summary>
        /// <param name="materia"></param>
        public void AdicionarMateria(Materia materia)
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
        public void AdicionarMaterias(List<Materia> materias)
        {
            materias.ForEach(materia =>
            {
                if (this.materias.Count < this.materias.Capacity && !this.materias.Contains(materia))
                {
                    this.materias.Add(materia);
                }
            });
        }

        /// <summary>
        /// Remove uma matéria se ela estiver na lista de matérias
        /// </summary>
        /// <param name="materia"></param>
        public void RemoverMateria(Materia materia)
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
        public bool ExisteAulaNoPeriodo(Materia materia)
        {
            Materia retorno = this.materias.Find(materia_ => materia_.GetPeriodo() == materia.GetPeriodo());
            return retorno != null;
        }
    }
}