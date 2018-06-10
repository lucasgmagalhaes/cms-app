using Class_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Management_System.Forms
{
    public partial class FormMateriasSemAula : Form
    {
        public FormMateriasSemAula(List<Aula> aulas)
        {
            InitializeComponent();
            this.CarregarMateriasNoGrid(aulas);
        }

        private void CarregarMateriasNoGrid(List<Aula> aulas)
        {
            if(aulas != null)
            {
                aulas.ForEach(aula => this.dataGridGrafo.Rows.Add(aula.GetDisciplina().GetPeriodo(), aula.GetDisciplina().GetNome(),
                    aula.GetProfessor().GetNome(), aula.GetAulasPorSemana()));
            }
        }
    }
}
