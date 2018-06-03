using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Class_Management_System.Entities;
using Class_Management_System.Services;
using Class_Management_System.Utils;

namespace Class_Management_System.Forms
{
    public partial class BuscaUsuario : Form
    {
        private readonly IDataBaseService dbService;
        private readonly IProcedureService procedureService;
        DataTable dtbPesquisa = new DataTable();
        public BuscaUsuario()
        {
            InitializeComponent();
            this.dbService = DependencyFactory.Resolve<IDataBaseService>();
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
            //MontaDtb();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> resultado = this.procedureService.BuscarUsuarios("");
                this.InserirResultadoNoDataGrid(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - BtnPesquisar_Click " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InserirResultadoNoDataGrid(List<Usuario> usuarios)
        {
            this.dtgPesquisa.Rows.Clear();
            usuarios.ForEach(usuario => this.dtgPesquisa.Rows.Add(usuario.PkUsuario, usuario.SLogin, usuario.SNome, usuario.SCPF,
                usuario.SEmail, usuario.Perfil.GetDescricao()));
        }

        public void MontaDtb()
        {
            try
            {
                dtbPesquisa.Columns.Add("ID", Type.GetType("System.Int32"));
                dtbPesquisa.Columns.Add("LOGIN", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("NOME", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("CPF", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("E-MAIL", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("PERFIL", Type.GetType("System.String"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro - MontaDtb " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            this.dtgPesquisa.Rows.Clear();
        }

        private void DtgPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPesquisa_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3 && e.Value != null)
                {
                    Double.TryParse(e.Value.ToString(), out double d);
                    e.Value = d.ToString(@"000\.000\.000-000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - DtgPesquisa_CellFormatting " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
